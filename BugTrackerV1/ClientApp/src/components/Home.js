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
   let category = document.getElementById('category').value;
   let description = document.getElementById('description').value;
   let priority = document.getElementById('priority').value;
  axios({
    method : 'post',
      url: 'https://localhost:44321/api/Issue',
      data : {
        Summary : summary,
        Category :category ,
        Description :description ,
        Priority : priority
      }
      

  }).then(res => {
    if(res.status == '200'){
         this.setState({
          status200 : 'Successfully added issue to database'
         })
       
    }
    else{
        this.setState({
          status200 : "Didn't add issue to database please try again."
        })   
    }
  })
 }


  render () {
 
    


   
 return (

   <div>
  <form action="">
     <input type="text" id="summary"  /> <br></br>
     <input type="text" id="category" /><br></br>
     <input type="text" id="description" /><br></br>
     <input type="text" id="priority" /><br></br>
     </form>


    
     <button onClick ={() => this.addIssueRequest()} >Add summary</button>
     <p >{this.state.status200}</p>
     <h1></h1>
   </div>
       
)

  

    }
  }
