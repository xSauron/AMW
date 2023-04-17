import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import obraz from './obraz.png';

function Left() {
  return (
    <div className="col-md-4 light-green">
        <h2>Aktualizacja i zamówienia materiałów</h2>
        <p>Do wewnętrznego użytku firmy</p>
        <img src={obraz} alt="sieć komputerowa" />
    </div>
  );
}

export default Left;