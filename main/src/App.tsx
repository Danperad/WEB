import React from 'react';
import './App.css';
import Charts from "./components/Chart";

class App extends React.Component {
  render() {
    return <Charts min={0} max={2.5} delta={0.01}/>;
  }
}

export default App;
