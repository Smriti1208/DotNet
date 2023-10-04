import React, { useState } from "react";
import "./CSS/SignIn.css";

const App = () => {
  const [formData, setFormData] = useState({
    name: "",
    email: "",
    password: "",
  });
}

  const [errors, setErrors] = useState({
    name: "",
    email: "",
    password: "",
  });


  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };


  const handleSubmit = (e) => {
    e.preventDefault();
    App();

    let isValid = true;

    // Name validation
    if (formData.name.length < 3) {
      isValid = false;
      setErrors({ ...errors, name: "Name must be at least 3 characters" });
    }

    // Email validation
    if (!formData.email.includes("@")) {
      isValid = false;
      setErrors({ ...errors, email: "Email must be a valid email address" });
    }

    // Password validation
    if (formData.password.length < 8) {
      isValid = false;
      setErrors({ ...errors, password: "Password must be at least 8 characters" });
    }

    if (isValid) {
      // Submit the form data to the server
      console.log(formData);
    }
  };

  return (
    <div className="App">
      <h1>Form Validation</h1>
      <form onSubmit={handleSubmit}>
        <label>
          Name:
          <input
            type="text"
            name="name"
            value={formData.name}
            onChange={handleChange}
          />
          {errors.name && <span className="error">{errors.name}</span>}
        </label>
        <label>
          Email:
          <input
            type="email"
            name="email"
            value={formData.email}
            onChange={handleChange}
          />
          {errors.email && <span className="error">{errors.email}</span>}
        </label>
        <label>
          Password:
          <input
            type="password"
            name="password"
            value={formData}
            />
            </label>
            </form>
            </div>
  )