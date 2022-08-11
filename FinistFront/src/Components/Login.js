import {React, useRef} from "react";
import {validateLogin, getBankAccounts} from '../HttpRequest';
import { useDispatch } from "react-redux";
import { setUserAction } from "../Redux/Reducers/UserReducer";
import { setBankAccountAction } from "../Redux/Reducers/BankAccountReducer";
export default function Login() {

    const loginRef = useRef();
    const passwordRef = useRef();
    const dispatch = useDispatch();

    const validateData = () => {
        const log = loginRef.current.value;
        const pass = passwordRef.current.value;

        if (log == "")
            return alert("Введите логин");
        if (pass == "")
            return alert("Введите пароль");
        validateLogin(log, pass)
        .then((res) => {
            dispatch(setUserAction(res));
            localStorage.setItem("user", JSON.stringify({log, pass}))            
            window.location.pathname = "/";
        })
        .catch((rep) => {
            alert("Не правильный логин или пароль");
        })
    }

    return (
        <section className="vh-100">
            <div className="container py-5 h-100">
                <div className="row d-flex justify-content-center align-items-center h-100">
                    <div className="col-12 col-md-8 col-lg-6 col-xl-5">
                        <div className="card shadow-2-strong" style={{borderRadius: "1rem"}}>
                            <div className="card-body p-5 text-center">
                                <h3 className="mb-5">Авторизация</h3>
                                <div className="form-floating mb-2 text-start">
                                    <input type="login" className="form-control" ref={loginRef} id="floatingInput" placeholder="Login"/>
                                    <label htmlFor="floatingInput">Логин</label>
                                </div>
                                <div className="form-floating mb-2 text-start">
                                    <input type="password" className="form-control" ref={passwordRef} id="floatingInput" placeholder="Password"/>
                                    <label htmlFor="floatingInput">Пароль</label>
                                </div>
                                <p className="btn btn-outline-dark btn-lg btn-block" onClick={validateData}>Войти</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    )
}