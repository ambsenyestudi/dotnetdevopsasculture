import logo from './logo.svg';
import React from 'react';
import ClickCounter from './counter/ClickCounter';
import './App.css';


const App = () => {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Count your clicks
        </p>
        <ClickCounter></ClickCounter>
      </header>
    </div>
  );
}

export default App;
