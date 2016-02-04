var chartData = [{
    name: ":)",
    showInLegend: true,
    type: "stackedColumn100",
    click: onClick,
    color: "#64FE2E",
    dataPoints: [{ label: "I-Phone", y: 33 },
                 { label: "Nexus", y: 40 },
                 { label: "Galaxy", y: 50 },
                 { label: "OnePlus", y: 60 }]
},
  {
      name: ":|",
      showInLegend: true,
      type: "stackedColumn100",
      click: onClick,
      color: "#FACC2E",
      dataPoints: [{ label: "I-Phone", y: 33 },
                   { label: "Nexus", y: 28 },
                   { label: "Galaxy", y: 18 },
                   { label: "OnePlus", y: 12 }]
  },
  {
      name: ":(",
      showInLegend: true,
      type: "stackedColumn100",
      click: onClick,
      color: "#FA5858",
      dataPoints: [{ label: "I-Phone", y: 33 },
                   { label: "Nexus", y: 15 },
                   { label: "Galaxy", y: 12 },
                   { label: "OnePlus", y: 10 }]
  }];

var featureData = [{
    name: ":)",
    showInLegend: true,
    type: "stackedColumn100",
    color: "#64FE2E",
    dataPoints: [{ label: "Camera", y: 30 }, { label: "Display", y: 40 }]
},
{
    name: ":|",
    showInLegend: true,
    type: "stackedColumn100",
    color: "#FACC2E",
    dataPoints: [{ label: "Camera", y: 40 }, { label: "Display", y: 28 }]
},
{
    name: ":(",
    showInLegend: true,
    type: "stackedColumn100",
    color: "#FA5858",
    dataPoints: [{ label: "Camera", y: 15 }, { label: "Display", y: 15 }]
}
];

$('.press').click(function () {
    createChart("Phones", chartData);
});

function onClick(e) {
    createChart(e.dataPoint.label, featureData);
}

createChart("Phones", chartData);




function createChart(chartTitle, chartData) {
    var chart = new CanvasJS.Chart("chartContainer", {
        title: { text: chartTitle, horizontalAlign: "right" },
        axisX: { tickThickness: 0, interval: 1 },
        animationEnabled: true,
        interactivityEnabled: true,
        toolTip: { content: "{label} <br/>{name} : {y}", shared: false },
        axisY: { lineThickness: 0, tickThickness: 0, interval: 20 },
        legend: { verticalAlign: "center", horizontalAlign: "left" },
        data: chartData
    });
    chart.render();
}


