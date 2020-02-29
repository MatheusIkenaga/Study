google.charts.load('current', {
    'packages': ['corechart']
  });
  google.charts.setOnLoadCallback(drawChart);

  function drawChart() {

    var data = google.visualization.arrayToDataTable([
      ['UF', 'Viagens'],
      ['SP - 212', 212],
      ['MG - 35', 35],
      ['RJ - 84', 84],
      ['RS - 37', 37],
      ['SC - 25', 25]
    ]);

    var options = {
      title: 'Estados Destino - Viagens'
    };

    var chart = new google.visualization.PieChart(document.getElementById('piechart'));

    chart.draw(data, options);
  }
