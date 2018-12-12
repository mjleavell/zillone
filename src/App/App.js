import React, { Component } from 'react';

import connection from '../helpers/data/connection';

import Auth from '../components/Auth/Auth';
import Listings from '../components/Listings/Listings';

import './App.scss';

class App extends Component {
  // defining the initial state in THIS component
  state = {
    authed: false, // initially when app loads i am not logged in
  }

  componentDidMount() {
    connection();
  }

  isAuthenticated = () => {
    this.setState({ authed: true });
  }

  render() {
    if (!this.state.authed) { // if this.state.authed is false then
      return (
        <div className="App">
          <Auth isAuthenticated={this.isAuthenticated}/>
        </div>
      );
    }
    return (
      <div className="App">
        <Listings />
      </div>
    );
  }
}

export default App;
