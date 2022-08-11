import {React, useEffect} from "react";
import Sidebar from "./SideBar";
import Header from "./Header";
import Footer from "./Footer";
import { useDispatch, useSelector } from "react-redux";
import { validateLogin } from "../HttpRequest";
import { setUserAction } from "../Redux/Reducers/UserReducer";
import MainPageRoot from "./MainPageContent/MainPageRoot";

export default function Main() {
    const user = useSelector(state => state.User.user);
    const dispatch = useDispatch();
    useEffect(() => {
        if (user == null) {
            const storageUser = JSON.parse(localStorage.getItem("user"));
            if (storageUser == null)
               return window.location.pathname = "/Login";
            validateLogin(storageUser.log, storageUser.pass)
            .then(res => {
                dispatch(setUserAction(res));
            })
            .catch (() => {
                window.location.pathname = "/Login";
            })
        }
    }, [])
    return (
        <div className="d-flex justify-content-start">
            <Sidebar/>                    
            <MainPageRoot/>
        </div>               
    )
}