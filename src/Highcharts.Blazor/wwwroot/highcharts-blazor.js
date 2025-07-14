// This function initializes a Highcharts chart in the specified container.
export function initializeChart(containerId, options) {
	if (!window.Highcharts) {
		console.error("Highcharts library is not loaded.");
		return;
	}

	const chartOptions = JSON.parse(options);

	Highcharts.chart(containerId, chartOptions);
}
