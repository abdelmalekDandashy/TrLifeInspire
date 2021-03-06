const INITIAL_STATE = {
  rightOrLeft: 'ltr',
  language: 'en'
};

export default function (state = INITIAL_STATE, action) {
  console.log(action.payload)
  switch (action.type) {
    case "SET_LANGUAGE":
      return {
        ...state,
        rightOrLeft: action.payload.rightOrLeft,
        language: action.payload.language,
      };
    default:
      return state;
  }
}
