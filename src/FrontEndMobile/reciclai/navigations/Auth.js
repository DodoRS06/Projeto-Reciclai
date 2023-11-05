import React from 'react';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

import Login from '../pages/Login';
import CadastroUsuario from '../pages/CadastroUsuario';

const Stack = createNativeStackNavigator();

const Auth = () => {
  return (
    <Stack.Navigator initialRouteName="Login">
      <Stack.Screen
        name="Login"
        component={Login}
        options={{
          header: () => null,
        }}
      />
      <Stack.Screen
        name="Register"
        component={CadastroUsuario}
        options={{
          header: () => null,
        }}
      />
    </Stack.Navigator>
  );
};

export default Auth;