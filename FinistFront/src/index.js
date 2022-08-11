import {React} from "react";
import {createRoot} from 'react-dom/client'
import {BrowserRouter} from 'react-router-dom'
import {Provider} from 'react-redux'
import {store} from "./Redux/store"
import App from './Components/App'

const elem = document.querySelector(".root");
const root = createRoot(elem);

root.render(
    <BrowserRouter>
        <Provider store={store}>            
            <App/>
        </Provider>
    </BrowserRouter>
)
