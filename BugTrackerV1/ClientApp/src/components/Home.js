import React, { Component } from 'react';
import Axios from 'axios';
import axios from 'axios';



export class Home extends Component {
  static displayName = Home.name;
  
  constructor(){
    super()
    this.state = {
      status200 : ''

    }

  }






 





 addIssueRequest(){
   let summary = document.getElementById('summary').value;
  
   let description = document.getElementById('description').value;
   let priority = document.getElementById('priority').value;
     axios({
         method: 'post',
         url: 'https://localhost:44321/api/Issue',
         data: {
             Summary: summary,
             Priority: priority,
             Description: description

         }


     });
    }
 


  render () {
 
    


   
 return (

   <div>
  <form action="">
 
     <input type="text" id="summary"  placeholder="summary"/> <br></br>
     <form>
         <select name = "dropdown" id="priority">
            <option selected  value="Priority">Priority </option>
            <option value = "Low" >Low </option>
            <option value = "Medium">Medium</option>
            <option value = "High">High</option>
         </select>
      </form>
   
     <input type="text" id="description" placeholder="Description"/><br></br>
     
     </form>


    
     <button onClick ={() => this.addIssueRequest()} >Add summary</button>
     <p >{this.state.status200}</p>
     <h1></h1>
   </div>
       
)

  

    }
  }
