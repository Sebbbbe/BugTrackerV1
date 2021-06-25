import React, { Component } from 'react';
import Axios from 'axios';
import axios from 'axios';



export class Home extends Component {
  static displayName = Home.name;
  

componentDidMount(){
  axios({
    method : 'get',
    url : 'https://localhost:44321/api/Issue'
  })
  .then(function (r){
    console.log(r);
  });
}


  render () {
 
   
   
 return (

   <div>
     <p>hej</p>
   </div>
       
)

  

    }
  }
