import React, { Component } from 'react'
import axios from 'axios';




export default class CreateIssue extends Component {


    constructor(props) {
        super(props);
        this.state = {
            todos: []
        };
    }


    componentDidMount(){
       
        console.log(`Form submitted: `);
        console.log(`Todo Description: ${this.state.summary}`);
      
     

        const newIssue = {
            summary: this.state.summary,
         
        };

        axios.post('https://localhost:44321/api/Issue', newIssue)
            .then(res => {
                console.log(res.data)
            })
        this.setState({
            summary: '',
           
        })
    }

    render() {
       
        return (
        
               <div>
               <input type="text" />
               <button>Add Issue</button>
               
               </div>
        );

    }

  
}