import { Route, Routes} from 'react-router-dom';
import {React} from 'react';
import Main from './Main';
import Login from './Login';
import Header from './Header';
import Footer from './Footer';

export default function App() {    
    return(
        <>
        <Header/>
            <Routes>
                <Route path='/Login' element={<Login/>}/>
                <Route path='' element={<Main/>}/>
            </Routes>
        <Footer/>
        </>
    )
}