const defaultState = {
    account: null
}
const setBankAccount = "setBankAccount";

export const setBankAccountAction = (value) => {
    return {type: setBankAccount, value: value}
}

 
export  const BankAccountReducer = (state = defaultState, action = {type: "", value: ""}) => {
    switch (action.type) {
        case setBankAccount:
            return {...state, account: action.value}
        default:
            return state
    }
}