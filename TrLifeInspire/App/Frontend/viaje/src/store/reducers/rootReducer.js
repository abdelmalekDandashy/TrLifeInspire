import { combineReducers } from 'redux';
import settings from './settings';
import auth from './auth';
import trips from './trips';

export default combineReducers({
  settings,
  auth,
  trips,
});