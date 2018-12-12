import firebase from 'firebase/app';
import 'firebase/auth';
import apiKeys from '../apiKeys';

const firebaseApp = () => {
  // if there is no firebase app, then initialize firebase
  if (!firebase.apps.length) {
    firebase.initializeApp(apiKeys.firebaseConfig);
  }
};

export default firebaseApp;
