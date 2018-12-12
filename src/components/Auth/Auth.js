import React from 'react';
import './Auth.scss';

// component is a method on react itself
class Auth extends React.Component {
  render() {
    return (
      <div className="Auth">
        <button className="btn btn-danger">Login</button>
      </div>
    );
  }
}

export default Auth;
