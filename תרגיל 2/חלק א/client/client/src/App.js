import './App.css';
import React, { useState } from 'react';
import service from "./userService";

function App() {

  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [tz, setTz] = useState("");
  const [dateOfBirth, setDateOfBirth] = useState(new Date());
  const [city, setCity] = useState("");
  const [street, setStreet] = useState("");
  const [buildingNumber, setBuildingNumber] = useState("");
  const [phone, setPhone] = useState("");
  const [mobilePhone, setMobilePhone] = useState("");

  const [users, setUsers] = useState([]);

  async function getUsers() {
   const users= await service.getUsers();
   setUsers(users);
  }

  async function addUser(e) {
    e.preventDefault();
    await service.addUser(firstName,lastName,tz,dateOfBirth,phone,mobilePhone,city,street,buildingNumber);
    
    await getUsers();//refresh tasks list (in order to see the new one)
  }

  return (
    <div>
     <button onClick={getUsers}>getUsers</button>
     <ul>
      {users.map(user =>{
        return (
          <li key={user.id}>
            {user.firstName + " "}
            {user.lastName + " "}
            {user.tz}
          </li>
        )
      })}
     </ul>
     <form onSubmit={addUser}>
          <input placeholder="first name" value={firstName} onChange={(e) => setFirstName(e.target.value)} />
          <input placeholder="last name" value={lastName} onChange={(e) => setLastName(e.target.value)} />
          <input placeholder="tz" value={tz} onChange={(e) => setTz(e.target.value)} />
          <input type="date" placeholder="date Of Birth" value={dateOfBirth} onChange={(e) => setDateOfBirth(e.target.value)} />
          <input placeholder="city" value={city} onChange={(e) => setCity(e.target.value)} />
          <input placeholder="street" value={street} onChange={(e) => setStreet(e.target.value)} />
          <input placeholder="building Number" value={buildingNumber} onChange={(e) => setBuildingNumber(e.target.value)} />
          <input placeholder="phone" value={phone} onChange={(e) => setPhone(e.target.value)} />
          <input placeholder="mobilePhone" value={mobilePhone} onChange={(e) => setMobilePhone(e.target.value)} />
          <button onSubmit={addUser}>submit</button>
        </form>
    </div>
  );
}

export default App;
