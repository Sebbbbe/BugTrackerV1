import React, {useState}  from 'react';
import {  Route, Link} from 'react-router-dom'
import {  Redirect, history } from 'react-router-dom'

const Home =  (props)  => {




  return (
 <div>

<Link to="/CreateIssue">
     <button type="button"
     data-cy="createIssueBtn">
          Create Issue
     </button> </Link>

     <Link to="/CreateProject">
     <button type="button"
     data-cy="createProjectBtn">
          Create Project
     </button> </Link>
 
</div>
  )
}

export default Home;


