

import { applyMiddleware, createStore, compose } from 'redux';
import thunk from 'redux-thunk';
import rootReducer from './store/reducers/rootReducer';


// Redux dev-tools setup
const composeEnhancers = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;
const store = createStore(
    rootReducer, composeEnhancers(applyMiddleware(thunk))
)
export function toObservable(store) {
    return {
        subscribe({ onNext }) {
            let dispose = store.subscribe(() => onNext(store.getState()));
            onNext(store.getState());
            return { dispose };
        },
    };
}
export default store;