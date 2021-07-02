import React , {Component} from 'react'
import Home from './components/Home'
import {  Route, Link, } from 'react-router-dom'
import CreateIssue from './components/Issues/CreateIssue';


function App() {
  return (
 
 <div>
 
   <Route exact path={'/'}  component={Home}   />
   <Route exact path={'/CreateIssue'}  component={CreateIssue}/>


 
 </div>
   )
 {/* <Link exact to = "CreateIssue">Create Issue</Link> */}
     {/* <Route path="/CreateIssue" component={CreateIssue}></Route> */}
 

}

export default App

