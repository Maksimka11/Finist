import {useDispatch} from 'react-redux';
import { setBankAccountAction } from './Redux/Reducers/BankAccountReducer';

function sendRequest(method, url, body = null) {
    return new Promise( (resolve, reject) => {
        const xhr = new XMLHttpRequest();
        xhr.open(method, url, true);
        xhr.responseType = 'json';
        xhr.setRequestHeader('Content-Type', 'application/json');
        xhr.onload = () => {
            if (xhr.status >= 400)
                reject(xhr.response);
            else
                resolve(xhr.response);
        }
        xhr.onerror = () => {
            reject(xhr.response);
        }
        xhr.send(JSON.stringify(body));
    })
}

const hostUrl = "https://localhost:7132";

export function validateLogin(login, password) {
    return sendRequest("GET", hostUrl + "/User/validate/"+ login + "/" + password);    
}

export function getBankAccount(UserId) {
    return sendRequest("GET", hostUrl + "/BankAccount/"+ UserId);
}

export function getDebetCards(accountId) {
    return sendRequest("GET", hostUrl + "/Card/Debet/"+ accountId);
}

export function getCreditCards(accountId) {
    return sendRequest("GET", hostUrl + "/Card/Credit/"+ accountId);
}

export function getTransactions(accountId) {
    return sendRequest("GET", hostUrl + "/Transaction/" + accountId);
}

export function getFavorites(accountId) {
    return sendRequest("GET", hostUrl + "/Favorite/" + accountId);
}