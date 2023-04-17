import React, {useState} from 'react';
import Left from './left.js';
import Right from './right.js';
import Header from './header.js';
import Footer from './footer.js';
import 'bootstrap/dist/css/bootstrap.min.css';
import './style.css';

function Page() {
    return(
        <div className="App">
            <Header />
            <div className="container-fluid">
                <div className="row">
                    <Left/>
                    <Right/>
                </div>
            
            </div>
            <Footer/>
        </div>
   )
}

export default Page;