import React, { useState } from "react";

const HealthInsuranceForm = () => {
  const [formData, setFormData] = useState({
    name: "",
    age: "",
    gender: "",
    smoker: false,
    healthConditions: [],
    medications: [],
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(formData);
  };

  return (
    <form onSubmit={handleSubmit}>
      <label>
        Name:
        <input type="text" name="name" value={formData.name} onChange={handleChange} />
      </label>
      <label>
        Age:
        <input type="number" name="age" value={formData.age} onChange={handleChange} />
      </label>
      <label>
        Gender:
        <select name="gender" value={formData.gender} onChange={handleChange}>
          <option value="male">Male</option>
          <option value="female">Female</option>
          <option value="other">Other</option>
        </select>
      </label>
      <label>
        Smoker:
        <input type="checkbox" name="smoker" checked={formData.smoker} onChange={handleChange} />
      </label>
      <label>
        Health Conditions:
        <input type="text" name="healthConditions" value={formData.healthConditions} onChange={handleChange} />
      </label>
      <label>
        Medications:
        <input type="text" name="medications" value={formData.medications} onChange={handleChange} />
      </label>
      <input type="submit" value="Submit"/>
    </form>
  );
};

export default HealthInsuranceForm;