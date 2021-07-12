import React , {useState} from 'react';
import axios from 'axios';
import useForm from '../Validation/useForm'

import validate from '../Validation/ValidateFormProject'


const CreateProject =  ()  => {

const {handleChange,handleSubmit , values, errors} = useForm(submit, validate);

  function submit(){
    console.log("Submitted Succesfully");
   
    
    
  }

  function addProjectRequest(){

    let projectName = document.getElementById('projectName').value;
    
      axios({
          method: 'post',
          url: 'https://localhost:44321/api/Project',
          data: {
           
            Project_Name : projectName
          }
 
 
      });
     }
  return (
    <div>


   
  <form  onSubmit={handleSubmit} noValidate>
 
  <input 
     
     type="text" 
     name="Project_Name"
     id="projectName"  
     placeholder="ProjectName"
      value ={values.ProjectName}
       onChange={handleChange}
       data-cy = "project"
       /> 
     
     <br></br>
     {errors.projectName && <p>{errors.projectName}</p>}
    

     <button 
     type="submit"
     data-cy = "addProjectBtn"
     onClick ={() => addProjectRequest()
     } >Add summary
     
     </button>
    
     </form>


    
     
     
  
   </div>
    
  )
}

export default CreateProject;


