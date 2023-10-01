import './App.css';


import { BrowserRouter as Router, Route, Routes, BrowserRouter} from 'react-router-dom';
import SignInPage from './Components/SignIn';
import SignUpPage from './Components/SignUp';


function App() {
  return (
    <div className="App">
      <header>
        <Router>
        <Routes>
        <Route path = {'/'} element = { <SignInPage/>}/> 
        <Route path = {'/SignUp'} element = { <SignUpPage/>}/> 
        </Routes> 
      </Router>
      </header>
     
    </div>
  );
}

export default App;
