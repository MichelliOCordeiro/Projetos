import React from 'react';
import { Route, BrowserRouter as Batata, Routes} from 'react-router-dom';
import { Footer } from './components/Footer';
import { Navbar } from './components/Navbar';
import { Home } from './pages/Home';
import { Login } from './pages/Login';
import { PecaJa } from './pages/PecaJa';

export const AppRoutes: any = () => {
    return(
        <Batata>
            <Navbar/>
        <Routes>
            <Route index element= {<Home/>} />
            <Route path='Login' element= {<Login/>} />  
            <Route path='PecaJa' element= {<PecaJa/>} />        
        </Routes>
            <Footer/>
        </Batata>
    )
 }
