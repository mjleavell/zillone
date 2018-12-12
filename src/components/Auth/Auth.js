import React from 'react';
import authRequests from '../../helpers/data/authRequests';
import './Auth.scss';

// component is a method on react itself
class Auth extends React.Component {
  authenticateUser = (e) => {
    e.preventDefault(); // need to have prevent default on all events to prevent bubbling up
    authRequests.authenticate().then(() => {
      this.props.isAuthenticated();
    }).catch(err => console.error('auth', err));
  }

  render() {
    return (
      <div className="Auth">
        <button className="btn btn-danger" onClick={this.authenticateUser}>Login</button>
      </div>
    );
  }
}

export default Auth;
