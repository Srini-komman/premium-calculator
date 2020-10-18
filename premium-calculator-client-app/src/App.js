import React from 'react';
import logo from './logo.svg';
import './App.css';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom';
import { CustomerDetails } from './components/customer/CustomerDetails';
import { Error } from './components/error/Error';
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <Router>
      <div className="App">
        <Switch>
        <Route path="/" exact component={CustomerDetails}></Route>
        <Route path="/customerDetails" component={CustomerDetails}></Route>
        <Route path="/error" component={Error}></Route>
        </Switch>      
      </div>
    </Router>
  );
}

export default App;
