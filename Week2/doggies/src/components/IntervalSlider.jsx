import { Slider } from "antd";
import { useEffect } from "react";

const IntervalSlider = ({min, max, fromState, toState}) => {

    const [from, setFrom] = fromState
    const [to, setTo] = toState

    useEffect(() => {
        setFrom(min);
        setTo(max);
    }, [])

    const onSliderChange = (value) => {
        setFrom(value[0])
        setTo(value[1])
    }

    const setMin = (e) => {
        setFrom(parseInt(e.target.value))
    }

    const setMax = (e) => {
        setTo(parseInt(e.target.value))
    }

    const validateInterval = () => {
        if (from > to){
            setFrom(to)
            setTo(from)
        }
        setFrom(prev => prev < min || isNaN(prev) ? min : prev)
        setTo(prev => prev > max || isNaN(prev) ? max : prev)
    }

    return (
        <>
            <Slider max={max} min={min} range onChange={onSliderChange} value={[from, to]}/>
            <p>
                <span>От:</span>
                <input type='number' onBlur={validateInterval} onChange={setMin} value={from} style={{marginLeft: 10, width: 130}}/>
            </p>
            <p>
                <span>До:</span>
                <input type='number' onBlur={validateInterval} onChange={setMax} value={to} style={{marginLeft: 10, width: 130}}/>
            </p>
        </>
    )
}

export default IntervalSlider;