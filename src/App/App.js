import React, { Component } from 'react';

import connection from '../helpers/data/connection';

import Auth from '../components/Auth/Auth';

import './App.scss';

class App extends Component {
  componentDidMount() {
    connection();
  }

  render() {
    return (
      <div className="App">
        {/* self closing div */}
        <Auth />
      </div>
    );
  }
}

export default App;
