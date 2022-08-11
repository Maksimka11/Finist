import {React} from "react";
import {NavLink} from "react-router-dom";


export default function Header() {    
    return (
        <div className="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start border-bottom">
            <h1 className="mx-5">Интернет банк</h1>
            <ul className="nav col-12 col-lg-auto me-lg-auto justify-content-center mb-md-0">
                <li><label className="nav-link px-2 link-secondary"><NavLink to="#" style={{textDecoration: "none"}}>ГЛАВНАЯ</NavLink></label></li>
                <li><label className="nav-link px-2 link-secondary"><NavLink to="#" style={{textDecoration: "none"}}>ПЛАТЕЖИ</NavLink></label></li>
                <li><label className="nav-link px-2 link-secondary"><NavLink to="#" style={{textDecoration: "none"}}>ИСТОРИЯ ОПЕРАЦИЙ</NavLink></label></li>
            </ul>
      </div>
    )
}