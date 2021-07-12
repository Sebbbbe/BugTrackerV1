export default function validate(values) {
 
    let errors = {};

    if(!values.Project_Name){
        errors.projectName = "projectName can't be empty";

      
    }
    
    // if(values.projectName.length > 50){
    //     errors.Project_Name = "projectName is too long max 50 characters"
    // }



  

  
    return errors;

}