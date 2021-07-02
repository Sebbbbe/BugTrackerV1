export default function validate(values) {
 
    let errors = {};

    if(!values.summary){
        errors.summary = "Summary can't be empty";

          if(values.summary.length > 50){
            errors.summary = "Summary is too long max 50 characters"
        }
    }
    
  


    if(values.priority.length > 6 ){
        errors.priority = "Please choose a priority"
    }

  

  if(values.description.length > 1000){
      errors.description = "Description can't be more than 1000 characters"
  }
 

    return errors;

}