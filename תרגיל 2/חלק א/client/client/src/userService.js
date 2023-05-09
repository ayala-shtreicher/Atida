import axios from 'axios';


axios.defaults.baseURL="https://localhost:7255/api/User";

axios.interceptors.response.use(function (response) {
    console.log("successfull",response.status);    
    return response;   
  }, function (error) {     
    console.log("error: ",error);
    return Promise.reject(error);   
  });
  
  export default {
    getUsers: async () => {
      const result = await axios.get();
      return result.data;
    },
  
    addUser: async(firstName,lastName,tz,dateOfBirth,phone,mobilePhone,{city,street,buildingNumber})=>{
      console.log('addUser', firstName);
      const result= await axios.post(`/`,{firstName,lastName,tz,dateOfBirth,phone,mobilePhone,city,street,buildingNumber});
      return result.data;
    },
}