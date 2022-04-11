import React from 'react';
import * as am5 from "@amcharts/amcharts5";
import * as am5xy from "@amcharts/amcharts5/xy";
import am5themes_Animated from "@amcharts/amcharts5/themes/Animated";

export declare type ChartProps = {
	min: number,
	max: number,
	delta: number
}

type Point = {
	x: number,
	y: number
}

class Chart extends React.Component<ChartProps> {
	funcMath() {
		let scores: Point[] = [];
		let y: number;
		for (let x = this.props.min; x < this.props.max; x += this.props.delta) {
			y = 3 * (x ** 3) - 2 ** (Math.E ** (x ** 3 - 2 * (x ** 2) - 1)) + (Math.log(x) / Math.log(13));
			scores.push({x: x, y: y});
		}
		return scores;
	};
	componentDidMount() {
		const root = am5.Root.new("what");

		root.setThemes([
			am5themes_Animated.new(root)
		]);

		let data = this.funcMath();

		let chart = root.container.children.push(
			am5xy.XYChart.new(root, {
				focusable: true,
				panX: true,
				panY: true,
				wheelX: "panX",
				wheelY: "zoomX"
			})
		);

		let xAxis = chart.xAxes.push(
			am5xy.ValueAxis.new(root, {
					min: this.props.min,
					max: this.props.max,
					renderer: am5xy.AxisRendererX.new(root, {})
				}
			)
		);

		let yAxis = chart.yAxes.push(
			am5xy.ValueAxis.new(root, {
				maxDeviation: 0.1,
				renderer: am5xy.AxisRendererY.new(root, {})
			})
		);

		let series = chart.series.push(
			am5xy.LineSeries.new(root, {
				xAxis: xAxis,
				yAxis: yAxis,
				valueYField: "y",
				valueXField: "x",
				tooltip: am5.Tooltip.new(root, {
					pointerOrientation: "horizontal",
					labelText: "{valueY}"
				})
			})
		);
		series.data.setAll(data);

		let legend = chart.children.push(am5.Legend.new(root, {}));
		legend.data.setAll(chart.series.values);

		let cursor = chart.set("cursor", am5xy.XYCursor.new(root, {
			xAxis: xAxis
		}));
		cursor.lineY.set("visible", false);

		chart.set("scrollbarX", am5.Scrollbar.new(root, {
			orientation: "horizontal"
		}));
	}

	render() {
		return <div>
			<h2 className={"chart-head"}>y = 3 * x^3 - 2^(e^(x^3 - 2 * x^2 - 1)) + log13(x)</h2>
			<div id="what" style={{ width: "100%", height: "500px" }}/>
		</div>;
	};
}

export default Chart;