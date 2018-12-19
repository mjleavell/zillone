import React from 'react';
import PropTypes from 'prop-types';
import './ListingForm.scss';
import authRequests from '../../helpers/data/authRequests';
import listingsRequests from '../../helpers/data/listingsRequests';

const defaultListing = {
  address: '',
  squareFootage: 0,
  price: 0,
  numBeds: 0,
  numBaths: 0,
  heating: '',
  cooling: '',
  imageUrl: '',
  uid: '',
};

class ListingForm extends React.Component {
  static propTypes = {
    onSubmit: PropTypes.func,
    isEditing: PropTypes.bool,
    editId: PropTypes.string,
  }

  state = {
    newListing: defaultListing,
  }

  formFieldStringState = (name, e) => {
    e.preventDefault();
    // have to make copy of listing then set the state
    // taking the object and spreading it out (spread operator)
    const tempListing = { ...this.state.newListing };
    // have to use bracket notation because it's a string
    tempListing[name] = e.target.value;
    this.setState({ newListing: tempListing });
  }

  // formFieldNumnberState = (name, e) => {
  // e.preventDefault();
  //   const tempListing = { ...this.state.newListing };
  //   tempListing[name] = e.target.value * 1;
  //   this.setState({ newListing: tempListing });
  // }

  addressChange = (e) => {
    this.formFieldStringState('address', e);
  }

  // priceChange = e => this.formFieldNumberState(num, e);

  formSubmit = (e) => {
    e.preventDefault();
    const { onSubmit } = this.props;
    const myListing = { ...this.state.newListing };
    myListing.uid = authRequests.getCurrentUid();
    onSubmit(myListing);
    this.setState({ newListing: defaultListing }); // clears out input
  }

  componentDidUpdate(prevProps) {
    const { isEditing, editId } = this.props;
    // if prevProps does not equal this.props and isEditing is true
    if (prevProps !== this.props && isEditing) {
      listingsRequests.getSingleListing(editId)
        .then((listing) => {
          this.setState({ newListing: listing.data });
        })
        .catch(err => console.error('error on componentDidUpdate', err));
    }
  }

  render() {
    const { newListing } = this.state;
    return (
      <div className="listing-form col">
        <h2>Add New Listing</h2>
        <form onSubmit={this.formSubmit}>
          <div className="form-group">
            <label htmlFor="address">Address:</label>
            <input type="text"
              className="form-control"
              id="address"
              aria-describedby="addressHelp"
              placeholder="Enter address"
              value={newListing.address}
              onChange={this.addressChange}
            />
          </div>
          <button className="btn btn-danger">Save Listing</button>
        </form>
      </div>
    );
  }
}

export default ListingForm;
