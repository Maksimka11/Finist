const defaultState = {
    debet: null,
    credit: null
}
const setDebet = "setDebet";
const setCredit = "setCredit";

export const setDebetAction = (value) => {
    return {type: setDebet, value: value}
}

export const setCreditAction = (value) => {
    return {type: setCredit, value: value}
}
export  const CardReducer = (state = defaultState, action = {type: "", value: ""}) => {
    switch (action.type) {
        case setDebet:
            return {...state, debet:action.value}
        case setCredit:
            return {...state, credit:action.value}
        default:
            return state
    }
}