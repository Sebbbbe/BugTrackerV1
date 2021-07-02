import React , {useState} from 'react';
import axios from 'axios';
import useForm from '../Validation/useForm'

import validate from '../Validation/ValidateForm'


const CreateIssue =  ()  => {

const {handleChange,handleSubmit , values, errors} = useForm(submit, validate);

  function submit(){
    console.log("Submitted Succesfully");
   
    
    
  }

  function addIssueRequest(){
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
  return (
    <div>
   {/*När man submittar kallar den på handlesubmit
   i andra klassen och sedan kallar tillbacka så vi får den */}

   
  <form  onSubmit={handleSubmit} noValidate>
 
     <input 
     type="text" 
     name="summary"
     id="summary"  
     placeholder="summary"
      value ={values.summary}
       onChange={handleChange}/> 
     
     <br></br>
     {errors.summary && <p>{errors.summary}</p>}
    
         <select  name="priority"  id="priority"  onChange={handleChange} > 
            <option  value="Priority">Priority </option>
            <option value = "Low" >Low </option>
            <option value = "Medium">Medium</option>
            <option value = "High">High</option>
            
            
         </select>
         
     {errors.priority && <p>{errors.priority}</p>}

         <br></br>
     
   
     <input  
     type="text"
     name="description"
      id="description" 
      placeholder="Description"
       value ={values.description} 
       onChange={handleChange}/>
           {errors.description && <p>{errors.description}</p>}
       <br></br>
   
     <button type="submit" onClick ={() => addIssueRequest()} >Add summary</button>
    
     </form>


    
     
     
  
   </div>
    
  )
}

export default CreateIssue;




