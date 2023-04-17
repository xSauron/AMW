import React, {useState} from 'react';

function Table() {
  const [tableData, setTableData] = useState([
      {
        id: 1,
        product: "Skrętka U/UTP drut",
        unit: "metr",
        quantity: 20,
      },
      {
        id: 2,
        product: "Skrętka U/UTP linka",
        unit: "metr",
        quantity: 2,
      },
      {
        id: 3,
        product: "Wtyki 8P8C",
        unit: "sztuki",
        quantity: 10,
      },
      {
        id: 4,
        product: "Moduły Keystone",
        unit: "sztuki",
        quantity: 30,
      },
  ]);

  const [orderCount, setOrderCount] = useState(1);

  const handleOrderClick = (id, product) => {
      setOrderCount(orderCount + 1);


      const message = `Zamówienie nr: ${orderCount}, Produkt: ${product}`;
      window.alert(message);
    };

  const handleUpdateClick = (id, currentQuantity) => {
    const newQuantity = prompt("Podaj nową ilość:", currentQuantity);
  
    if (newQuantity !== null && !isNaN(newQuantity)) {
      const updatedData = tableData.map((row) => {
        if (row.id === id) {
          return {
            ...row,
            quantity: parseInt(newQuantity),
          };
        }
        return row;
      });
  
      setTableData(updatedData);
    }
  };
  
  const getClassForAvailability = (quantity) => {
    if (quantity === 0) {
      return "bg-danger";
    } else if (quantity >= 1 && quantity <= 5) {
      return "bg-warning";
    } else {
      return "bg-honeydew";
    }
  };
      
return (
    <table>
    <thead>
      <tr>
        <th>LP</th>
        <th>Produkt</th>
        <th>Jednostka</th>
        <th>Dostępna ilość</th>
        <th>Aktualizacja</th>
        <th>Zamówienie</th>
      </tr>
    </thead>
    <tbody>
        {tableData.map((row) => (
            <tr key={row.id}>
            <td>{row.id}</td>
            <td>{row.product}</td>
            <td>{row.unit}</td>
            <td className={getClassForAvailability(row.quantity)}>
              {row.quantity}
            </td>
            <td>
                <button className="btn btn-success" onClick={() => handleUpdateClick(row.id, row.quantity)}>Aktualizuj</button>
            </td>
            <td>
                <button className="btn btn-success" onClick={() => handleOrderClick(row.id, row.product)}>
                Zamów
              </button>
            </td>
            </tr>
        ))}
    </tbody>
    </table>)
}

export default Table;