import Interval from "./Interval"

const DoubleMetricProperty = ({header, property}) => {
    return (
        <>
            <h4>{header}</h4>
            <ul>
                <li>Imperial: {<Interval interval={property && property.imperial}/>}</li>
                <li>Metric: {<Interval interval={property && property.metric}/>}</li>
            </ul>
        </>)
}

export default DoubleMetricProperty;