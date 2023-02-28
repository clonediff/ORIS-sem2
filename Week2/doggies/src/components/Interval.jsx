const Interval = ({interval}) => {
    return <>{interval && (interval.start == interval.end ? 
        `${interval.start}` : 
        `${interval.start} - ${interval.end}`)}</>
} 

export default Interval