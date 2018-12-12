import firebase from 'firebase/app';
import 'firebase/auth';
import apiKeys from '../apiKeys';

const firebaseApp = () => {
  // if there is no firebase app, then initialize firebase
  console.log(firebase.apps);
  if (!firebase.apps.length) {
    console.log('hi');
    firebase.initializeApp(apiKeys.firebaseConfig);
  }
};

export default firebaseApp;
