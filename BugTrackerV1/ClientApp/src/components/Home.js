import React, {useState}  from 'react';
import {  Route, Link} from 'react-router-dom'
import {  Redirect, history } from 'react-router-dom'

const Home =  (props)  => {




  return (
 <div>

<Link to="/CreateIssue">
     <button type="button">
          Create Issue
     </button> </Link>

     
 
</div>
  )
}

export default Home;


