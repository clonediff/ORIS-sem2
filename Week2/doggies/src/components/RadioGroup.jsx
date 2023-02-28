import { Radio } from "antd";

const RadioGroup = ({values, radioValueState}) => {

    const [radioValue, setRadioValue] = radioValueState

    const setRadio = (e) => setRadioValue(e.target.value)

    return (
        <Radio.Group onChange={setRadio} value={radioValue}>
            {values.map(item => item && <Radio key={`${item}`} value={item}>{item}</Radio>)}
        </Radio.Group>
    )
}

export default RadioGroup;