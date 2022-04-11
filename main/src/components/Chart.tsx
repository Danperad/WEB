import React from 'react';
import {Chart} from "react-google-charts";

export declare type Nazvanie = {
	min: number,
	max: number,
	delta: number
}

class Charts extends React.Component<Nazvanie> {
	funcMath() {
		let scores: [any[]] = [["X", "Y"]];
		let y: number;
		for (let x = this.props.min; x < this.props.max; x += this.props.delta) {
			y = 3 * (x ** 3) - 2 ** (Math.E ** (x ** 3 - 2 * (x ** 2) - 1)) + (Math.log(x) / Math.log(13));
			scores.push([x, y]);
		}
		return scores;
	};

	render() {
		return <div>
			<Chart chartType="Line" width={"100%"} height={"400px"} data={this.funcMath()} />
		</div>;
	};
}

export default Charts;