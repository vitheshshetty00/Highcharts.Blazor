
// This is the interop Javascript file that handles all interop between Blazor and Javascript

window.renderHighchartChart = function (containerId, chartOptions) {
    let options = '';
    try {
        options = JSON.parse(chartOptions, reviver);
    } catch (e) {
        console.log(`You might have a syntax error in your function call from Blazor`);
        console.log(e.message);
        console.log(e.stack);
    }
    Highcharts.chart(containerId, options);
}

window.addSeries = function (chartId, seriesJson) {
    const chart = Highcharts.charts.find(c => c && c.renderTo.id === chartId);
    if (chart) {
        const series = JSON.parse(seriesJson, reviver);
        chart.addSeries(series);
    }
}

window.removeSeries = function (chartId, seriesIndex) {
    const chart = Highcharts.charts.find(c => c && c.renderTo.id === chartId);
    if (chart && chart.series[seriesIndex]) {
        chart.series[seriesIndex].remove();
    }
}

window.addPoint = function (chartId, seriesIndex, pointJson, redraw, shift) {
    const chart = Highcharts.charts.find(c => c && c.renderTo.id === chartId);
    if (chart && chart.series[seriesIndex]) {
        const point = JSON.parse(pointJson, reviver);
        chart.series[seriesIndex].addPoint(point, redraw, shift);
    }
}

window.updateSeriesData = function (chartId, seriesIndex, dataJson) {
    const chart = Highcharts.charts.find(c => c && c.renderTo.id === chartId);
    if (chart && chart.series[seriesIndex]) {
        const data = JSON.parse(dataJson, reviver);
        chart.series[seriesIndex].setData(data);
    }
}

window.updateSeriesAtIndexHighchartChart = function (containerId, seriesIndex, seriesData) {
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i] && Highcharts.charts[i].renderTo.id === containerId && document.getElementById(Highcharts.charts[i].container.id) != null) {
            let jsonData = "";
            try {
                jsonData = JSON.parse(seriesData, reviver)
            } catch (e) {
                console.log(e.message);
                console.log(e.stack);
            }
            Highcharts.charts[i].series[seriesIndex].setData(jsonData);
            break;
        }
    }
}

window.updateTitleHighchartChart = function (containerId, titleText, titleColor) {
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i] && Highcharts.charts[i].renderTo.id === containerId && document.getElementById(Highcharts.charts[i].container.id) != null) {
            Highcharts.charts[i].update({
                title: {
                    text: titleText,
                    style: {
                        color: titleColor
                    }
                }
            });
            break;
        }
    }
}

window.updateXAxisPlotLineValue = function (containerId, plotlineVal, plotlineIndex) {
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i] && Highcharts.charts[i].renderTo.id === containerId && document.getElementById(Highcharts.charts[i].container.id) != null) {
            Highcharts.charts[i].xAxis[0].options.plotLines[plotlineIndex].value = plotlineVal;
            Highcharts.charts[i].xAxis[0].update();
            break;
        }
    }
}

window.updateYAxisPlotLineValue = function (containerId, plotlineVal, plotlineIndex) {
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i] && Highcharts.charts[i].renderTo.id === containerId && document.getElementById(Highcharts.charts[i].container.id) != null) {
            Highcharts.charts[i].yAxis[0].options.plotLines[plotlineIndex].value = plotlineVal;
            Highcharts.charts[i].yAxis[0].update();
            break;
        }
    }
}

window.updateXAxisCategories = function (containerId, categories) {
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i] && Highcharts.charts[i].renderTo.id === containerId && document.getElementById(Highcharts.charts[i].container.id) != null) {
            Highcharts.charts[i].xAxis[0].setCategories(categories);
            break;
        }
    }
}

window.updateChart = function (containerId, newChart) {
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i] && Highcharts.charts[i].renderTo.id === containerId && document.getElementById(Highcharts.charts[i].container.id) != null) {
            Highcharts.charts[i].update(JSON.parse(newChart, reviver));
            break;
        }
    }
}

window.redraw = function (chartId) {
    const chart = Highcharts.charts.find(c => c && c.renderTo.id === chartId);
    if (chart) {
        chart.redraw();
    }
}

window.destroyCharts = function () {
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i]) {
            Highcharts.charts[i].destroy();
        }
    }
    const x = Number(Highcharts.chart.length);
    for (var i = 0; i <= x; i++) {
        Highcharts.charts.pop(0);
    }
}

window.disposeHighchartChart = function (containerId) {
    let count = -1;
    let shouldPop = false;
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i] && Highcharts.charts[i].renderTo.id === containerId) {
            Highcharts.charts[i].destroy();
            shouldPop = true;
            break;
        }
        count++;
    }
    if (shouldPop === true) {
        Highcharts.charts.pop(count);
    }
}

window.setEvents = function (chartId, component) {
    const chart = Highcharts.charts.find(c => c && c.renderTo.id === chartId);
    if (chart) {
        chart.update({
            plotOptions: {
                series: {
                    point: {
                        events: {
                            click: function () {
                                component.invokeMethodAsync('HandlePointClick', {
                                    x: this.x,
                                    y: this.y,
                                    seriesIndex: this.series.index,
                                    seriesName: this.series.name
                                });
                            }
                        }
                    }
                }
            }
        });
    }
}

function reviver(key, value) {
    if (typeof (value) === 'string' && value.includes('function()')) {      
        let func = new Function(value.split("function()")[1]);
        return func;
    }
    return value
    // So the temporary workaround to pass actual javascript functions
    // is to write them as function() {}
    // the reviver on javascript side will look at this style and then convert
    // it into a new Function(replaceTextFunction);
    // Don't love this workaround, will investigate for something better.
    // The reasoning behind this is dotnet is already reviving any object 
    // passed as an argument to blazor as JSON string and then casting to a object again.
}

