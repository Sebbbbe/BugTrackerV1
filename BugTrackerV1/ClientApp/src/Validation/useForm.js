import {useState} from  'react';

const useForm = (callBack , validate) => {
    // kan just nu inte skriva mer än 1 bokstav då den resettar måste göra en setValues
    const [values, setValues] = useState({summary : "" , description: "" , priority : "priority"});
    const [errors, setErrors] = useState({summary : "" ,description: "" ,  priority : ""});

   const handleChange = event => {
  //  const {name , value} = event

//setValues name : value lätt sätt att ta ut värde från input
    setValues({
      ...values,
      [event.target.name] : event.target.value

    })
  
   }

   const handleOption = event => {
     setValues ({

     })
   }

   const handleSubmit = event => 
   { 
     event.preventDefault();
     setErrors(validate(values));
    
    callBack();
  
   }

  

   return {
    values,
    handleChange,
    handleSubmit,
    errors
   }
}
export default useForm;