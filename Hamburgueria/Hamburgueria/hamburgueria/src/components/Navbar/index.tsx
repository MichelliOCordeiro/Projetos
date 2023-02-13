import { Link } from "react-router-dom";
import './styles.css'

export const Navbar: React.FC = () => {
  return (
    <nav>
    <ul>
      <li><Link to={"Home"}>Hambúrgueres</Link></li>
      <li><Link to={"Home"}>Shakes</Link></li>
      <li><Link to={"Home"}>História</Link></li>
      <li><Link to={"Home"}>Local</Link></li>
      <li><Link to={"Login"}>Login</Link></li>
      <li><Link to={"Home"}>Principal</Link></li>
      <li><Link to={"PecaJa"}>Peça já</Link></li>
    </ul>
    </nav>
  );
}