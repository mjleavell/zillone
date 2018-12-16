/* eslint-disable max-len */
import React, { Component } from 'react';
import firebase from 'firebase/app';
import 'firebase/auth';

import connection from '../helpers/data/connection';

import Auth from '../components/Auth/Auth';
import MyNavbar from '../components/MyNavbar/MyNavbar';
import Listings from '../components/Listings/Listings';
import Building from '../components/Building/Building';
import ListingForm from '../components/ListingForm/ListingForm';

import './App.scss';
import authRequests from '../helpers/data/authRequests';

class App extends Component {
  // defining the initial state in THIS component
  state = {
    authed: false, // initially when app loads i am not logged in
  }

  componentDidMount() {
    connection();
    // only happens when you refresh the page
    this.removeListener = firebase.auth().onAuthStateChanged((user) => {
      if (user) {
        this.setState({
          authed: true,
        });
      } else {
        this.setState({
          authed: false,
        });
      }
    });
  }

  componentWillUnmount() {
    this.removeListener();
  }

  // might get away with taking this out because defined above
  isAuthenticated = () => {
    this.setState({ authed: true });
  }

  render() {
    const logoutClickEvent = () => {
      authRequests.logoutUser();
      this.setState({ authed: false });
    };

    if (!this.state.authed) { // if this.state.authed is false then
      return (
        <div className="App">
          <MyNavbar isAuthed={this.state.authed} />
          <div className="row">
            <Auth isAuthenticated={this.isAuthenticated}/>
          </div>
        </div>
      );
    }
    return (
      <div className="App">
        <MyNavbar isAuthed={this.state.authed} logoutClickEvent={logoutClickEvent}/>
        <div className="row">
          <Listings />
          <Building />
        </div>
        <div className="row">
          <ListingForm />
        </div>
      </div>
    );
  }
}

export default App;
