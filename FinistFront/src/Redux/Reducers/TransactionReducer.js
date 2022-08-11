const defaultState = {
    transactions: null
}
const setTransaction = "setTransaction";

export const setTransactionAction = (value) => {
    return {type: setTransaction, value: value}
}

 
export const TransactionReducer = (state = defaultState, action = {type: "", value: ""}) => {
    switch (action.type) {
        case setTransaction:
            return {...state, transactions: action.value}
        default:
            return state
    }
}