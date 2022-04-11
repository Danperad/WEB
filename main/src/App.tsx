import React from 'react';
import './App.css';
import Chart from "./components/Chart";

class App extends React.Component {
  render() {
    return <Chart min={0.000001} max={2.5} delta={0.001}/>;
  }
}

export default App;
