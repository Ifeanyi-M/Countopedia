import Logo from './images/React logo.png'

const Header = () => {
  return (
    <div className="py-2 p1-2 container-fluid" style={{borderBottom: "1px solid #777"}}>
        <img src={Logo} alt="" style={{height:"35px", verticalAlign:"top"}}/>
        <span className="h2 pt-4  m-2  text-white-50"> Countopedia</span>

    </div>
  )
}

export default Header  