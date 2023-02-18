const DoubleMetricProperty = ({header, property}) => {
    return (
        <>
            <h4>{header}</h4>
            <ul>
                <li>Imperial: {property && property.imperial}</li>
                <li>Metric: {property && property.metric}</li>
            </ul>
        </>)
}

export default DoubleMetricProperty;