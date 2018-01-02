import React from 'react';
import ReactDOM from 'react-dom';
import {BrowserRouter,Route} from 'react-router-dom';
import 'semantic-ui-css/semantic.min.css';
import './Style/index.css';
import App from './App';
import registerServiceWorker from './registerServiceWorker';

const supportsHistory = 'pushState' in window.history;
ReactDOM.render(
    <BrowserRouter forceRefresh={!supportsHistory}>
        <Route path="/" component={App} />
    </BrowserRouter>, 
    document.getElementById('root'));
registerServiceWorker();