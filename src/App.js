import logo from './logo.svg';
import React, {useState} from 'react';
import ClickCounter from './counter/ClickCounter';
import './App.css';


const App = () => {
  const [count, setCount] = useState(0);
  const increment = () => setCount(currCount => currCount + 1);
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Count your clicks
        </p>
        <ClickCounter handleClick={increment}>{count}</ClickCounter>
      </header>
    </div>
  );
}

export default App;
