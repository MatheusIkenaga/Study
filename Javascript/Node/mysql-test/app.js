// CREATING CONNECTION


const mysql = require ('mysql')
const connection = mysql.createConnection({
    host: '127.0.0.1',
    user: 'mysql-test',
    password: 'Mysqltest123',
    database: 'sitepoint'
})
connection.connect((err)=> {
    if(err) throw err
    console.log('Connected!')
})

// SELECT METHOD


/*
connection.query('Select * from authors', (err, rows) => {
    if(err) throw err
    
    console.log('Data receiber from Db')
    console.log(rows)
    console.log('----------------------------')
})

*/

connection.query('Select * from authors', (err, rows) => {
    if(err) throw err
    rows.forEach((row) =>{
        console.log(`${row.name} lives in ${row.city}`)
    })
})


//  INSERT METHOD

/*
const author = { 
    name: 'Matheus Ikenaga',
    city: 'Sao Paulo',
}

connection.query('INSERT INTO authors SET ?', author, (err, res)=>{
    if(err) throw err
    console.log('Last insert ID: ', res.insertId)
})
*/


// UPDATE METHOD

/*
connection.query('UPDATE authors SET city =? Where ID = ?',
['Rio de Janeiro', 3],
(err, result)=>{
    if (err) throw err

    console.log(`CHANGED ${result.changedRows} row(s)`)
}
)
*/



// DELETE METHOD
/*
connection.query('Delete from authors where id=?',
[5],
(err, result)=>{
    if(err) throw err

    console.log(`Deleted ${result.affectedRows} row(s)`)
})
*/